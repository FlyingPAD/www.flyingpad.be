import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinksEditionComponent } from './links-edition.component';

describe('LinksEditionComponent', () => {
  let component: LinksEditionComponent;
  let fixture: ComponentFixture<LinksEditionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LinksEditionComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LinksEditionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
