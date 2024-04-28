import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodEditionComponent } from './mood-edition.component';

describe('MoodEditionComponent', () => {
  let component: MoodEditionComponent;
  let fixture: ComponentFixture<MoodEditionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodEditionComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodEditionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
