import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditionMenuComponent } from './edition-menu.component';

describe('EditionMenuComponent', () => {
  let component: EditionMenuComponent;
  let fixture: ComponentFixture<EditionMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditionMenuComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditionMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
